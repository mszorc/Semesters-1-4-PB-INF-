#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

int ITER;
int N;
int  counter = 0;
pthread_mutex_t mymutex = PTHREAD_MUTEX_INITIALIZER;

void *count()
{
	int i;
  for(i=0;i<ITER;i++)
  {
		pthread_mutex_lock(&mymutex);
    counter++;
		pthread_mutex_unlock(&mymutex);
  }
}

int main(int argc, char* argv[])
{
	if (argc!=3)
	{
		perror("Wrong number of arguments\n");
		exit(EXIT_FAILURE);
	}	
	
	int i;
	N = atoi(argv[1]);
	ITER = atoi(argv[2]);	
	
	pthread_t *threads = (pthread_t*)malloc(sizeof(pthread_t)*N);	

	for (i=0;i<N;i++)
	{
		pthread_create(&threads[i], NULL, &count, NULL);
	}
	
	for (i=0;i<N;i++)
	{
		pthread_join(threads[i],NULL);
	}
	
	printf("%d\n",counter);
	pthread_mutex_destroy(&mymutex);
  exit(EXIT_SUCCESS);
}
