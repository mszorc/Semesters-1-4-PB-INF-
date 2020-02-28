#include <stdio.h>
#include <stdlib.h>
#include "read.h"
#include <fcntl.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <unistd.h>
int main(int argc, char *argv[])
{
int fd;
int i;
if (argc==1)
{
printf("Nie podano nazw plików\n");
}
else
{
	for (i=1;i<argc;i++)
	{
		fd=open(argv[i],O_RDONLY);
		if (fd==-1)
		{
			perror(argv[i]);
			return 1;
		}
		else
		{
			printf("Zawartość pliku %s\n",argv[i]);
			readfile(fd);
		}
	}
}
return 0;
}
