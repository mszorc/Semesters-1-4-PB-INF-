#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

void *count();
void *print();
int  counter = 0;

int main()
{
   pthread_t thread1, thread2;

   pthread_create(&thread1, NULL, &print, NULL);
   pthread_create(&thread2, NULL, &count, NULL);

   pthread_join(thread1, NULL);
   pthread_join(thread2, NULL);

   exit(EXIT_SUCCESS);
}

void *count()
{
   for(;;)
   {
      counter++;
   }
}

void *print()
{
    for(;;)
    {
       printf("%d\n", counter);
    }

}

