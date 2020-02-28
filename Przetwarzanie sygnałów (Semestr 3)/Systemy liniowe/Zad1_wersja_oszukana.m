N=32;
n=0:1:N;
x1=sin(2*pi*n/N);
x2=ones(1,N+1);
y1=S1(x1)+S1(x2);
y2=S1(x1+x2);
figure
subplot(2,2,1);
plot(n,x1);
axis([1 32 -1 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x1[n]");
subplot(2,2,2);
plot(x2);
axis([1 32 0 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x2[n]");
subplot(2,2,3);
plot(y1);
axis([1 32 0 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("S{x1[n]}+S{x2[n]}");
subplot(2,2,4);
plot(y2);
axis([1 32 0 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("S{x1[n]+x2[n]}");




y1=S2(x1)+S2(x2);
y2=S2(x1+x2);
figure
subplot(2,2,1);
plot(n,x1);
axis([1 32 -1 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x1[n]");
subplot(2,2,2);
plot(x2);
axis([1 32 0 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x2[n]");
subplot(2,2,3);
plot(y1);
axis([1 32 0 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("S{x1[n]}+S{x2[n]}");
subplot(2,2,4);
plot(y2);
axis([1 32 0 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("S{x1[n]+x2[n]}");






y1=S3(x1)+S3(x2);
y2=S3(x1+x2);
figure
subplot(2,2,1);
plot(n,x1);
axis([1 32 -1 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x1[n]");
subplot(2,2,2);
plot(x2);
axis([1 32 0 4]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x2[n]");
subplot(2,2,3);
plot(y1);
axis([1 32 -0.3 0.3]);
xlabel("Numer probki");
ylabel("Amplituda");
title("S{x1[n]}+S{x2[n]}");
subplot(2,2,4);
plot(y2);
axis([1 32 -0.3 0.3]);
xlabel("Numer probki");
ylabel("Amplituda");
title("S{x1[n]+x2[n]}");