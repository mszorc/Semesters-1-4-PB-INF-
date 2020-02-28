#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <unistd.h>

int N = 5;
pthread_mutex_t forks[5];

void* function(void* value)
{
	int n = (long) value;
	while(1)
	{
		printf("Philosopher %d is thinking\n",n);

		pthread_mutex_lock(&forks[n]);
		pthread_mutex_lock(&forks[(n+1)%N]);

		printf("Philosopher %d is eating\n",n);

		sleep(3);

		pthread_mutex_unlock(&forks[n]);
		pthread_mutex_unlock(&forks[(n+1)%5]);

		printf("Philosopher %d finished eating\n",n);
	}
}

int main(int argc, char* argv[])
{
	int i;

	pthread_t philosophers[N];

	for (i=0;i<N;i++)
	{
		pthread_mutex_init(&forks[i], NULL);
	}

	for (i=0;i<N;i++)
	{
		pthread_create(&philosophers[i], NULL, &function, (void*)(long) i);
	}

	for (i=0;i<N;i++)
	{
		pthread_join(philosophers[i],NULL);
	}

	for (i=0;i<N;i++)
	{
		pthread_mutex_destroy(&forks[i]);
	}
  exit(EXIT_SUCCESS);
}
