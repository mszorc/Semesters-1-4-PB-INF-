#include <stdio.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <unistd.h>
#include <fcntl.h>
#include <stdlib.h>
int main (int argc, char *argv[])
{
    if (argc!=2)
    {
	perror("Wrong number of arguments\n");
	return 1;
    }
    int fds[2];
    pid_t pid;
    /* Create a pipe. File descriptors for the two ends of the pipe are placed in fds. */
    /* TODO add error handling for system calls like pipe, fork, etc. */
    if(pipe (fds)) perror ("Pipe failure\n");
    /* Fork a child process. */
    pid = fork ();
    
    if (pid == (pid_t) 0) {
	int fd = open (argv[1],O_WRONLY | O_CREAT, S_IRUSR | S_IWUSR | S_IRGRP | S_IROTH);
	if(fd== -1) perror ("Failed to open file\n");
	dup2(fd,1);
        /* This is the child process. Close our copy of the write end of the file descriptor. */
        close (fds[1]);
        /* Connect the read end of the pipe to standard input. */
        dup2 (fds[0], STDIN_FILENO);
        /* Replace the child process with the "sort” program. */
        if(execlp ("sort", "sort", NULL)) perror ("Exec error\n");

    } 
    else if(pid < (pid_t) 0) perror ("Fork failed\n");
    else 
    {
        /* This is the parent process. */
        FILE* stream;
        /* Close our copy of the read end of the file descriptor. */
        close (fds[0]);
        /* Convert the write file descriptor to a FILE object, and write to it. */
        stream = fdopen (fds[1], "w");
        fprintf (stream, "This is a test.\n");
        fprintf (stream, "Hello, world.\n");
        fprintf (stream, "My dog has fleas.\n");
        fprintf (stream, "This program is great.\n");
        fprintf (stream, "One fish, two fish.\n");
        fflush (stream);
        close (fds[1]);
        /* Wait for the child process to finish. */
        waitpid (pid, NULL, 0);
    }
    return 0;
}
