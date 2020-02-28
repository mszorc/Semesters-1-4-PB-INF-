#include <signal.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <syslog.h>

volatile sig_atomic_t flag;

void handler(int signum){
    printf("signal!\n");
    if (signum==SIGQUIT){
    	flag=0;
    	syslog(LOG_INFO,"SIGQUIT handled");
    } 
}

int main(void){
    flag = 1;
    openlog("log_signal.c", LOG_NDELAY, LOG_NDELAY);
    signal(SIGINT, handler);
    signal(SIGQUIT, handler);
    syslog(LOG_INFO,"signal.c working");
    while(flag)
    {
        printf("working...\n");
        sleep(1);
    }
    closelog();
    return 0;
}
