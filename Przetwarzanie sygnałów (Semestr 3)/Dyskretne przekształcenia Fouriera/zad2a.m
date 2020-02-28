N=32;
n=0:1:N;
y1=cos(2*pi*n/N+pi/4);
y2=0.5*cos(4*pi*n/N);
y3=0.25*cos(8*pi*n/N+pi/2);
y4=y1+y2+y3;
y1fft=2*fft(y1)/N;
y2fft=2*fft(y2)/N;
y3fft=2*fft(y3)/N;
y4fft=2*fft(y4)/N;
figure
hold on
plot(n,y1);
plot(n,y2);
plot(n,y3);
plot(n,y4);
xlabel('Numer probki');
ylabel('Wartosc');
legend('y1[n]=cos(2\pin/N+\pi/4)','y2[n]=0.5cos(4\pin/N)','y3[n]=0.25cos(8\pin/N+\pi/2)','y4[n]=y1+y2+y3');
hold off
