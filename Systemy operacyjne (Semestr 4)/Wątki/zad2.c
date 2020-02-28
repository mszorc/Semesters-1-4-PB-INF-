#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <time.h>

void *function(void * nr)
{
	int i, random;
	random = rand() % 11;

	for(i=0;i<random;i++)
  {
		printf("Watek %d, iteracja %d\n", (int *)nr, i);
  }
}

int main()
{
	srand(time(0));
	pthread_t threads[10];
	int i, *retadr, counter = 0;
	int j = 10;

	for (i=0;i<j;i++)
	{
		pthread_create(&threads[i], NULL, &function, (void*) i);
	}
	
	for (i=0;i<j;i++)
	{
		pthread_join(threads[i],(void**) &retadr);
		counter += (int) retadr;
	}
	printf("Laczna liczba iteracji wykonana przez wszystkie watki: %d\n", counter);
	exit(EXIT_SUCCESS);
}
