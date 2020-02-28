#include <stdio.h>
#include <stdlib.h>
#include "read.h"
#include <fcntl.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <unistd.h>
void readfile(int fd) 
{
  unsigned char buffer[16]; 
  size_t bytes_read=0; 
  int i;
  do 
  {
	bytes_read = read (fd, buffer, sizeof (buffer)); 
	for (i = 0; i < bytes_read; ++i) putchar(buffer[i]); 
  }while (bytes_read == sizeof (buffer)); 
  close (fd); 
} 
