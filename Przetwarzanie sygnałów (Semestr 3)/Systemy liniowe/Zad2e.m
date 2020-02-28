N=64;
n=0:1:N-1;
k=32;
x1=sin(2*pi*n/N);
x2=sin(4*pi*n/N);
h=double(kroneckerDelta(sym(n), k));

figure
subplot(3,2,1);
plot(n,x1);
axis([0 80 -1 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x1");

subplot(3,2,2);
plot(conv(x1+x2,h));
axis([0 150 -2 2]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Splot sumy (x1+x2)*h");

subplot(3,2,3);
plot(n,x2);
axis([0 80 -1 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x2");

subplot(3,2,4);
plot(conv(x1,h)+conv(x2,h));
axis([0 150 -2 2]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Suma splotów x1*h+x2*h");

subplot(3,2,5);
stem(n,h);
axis([0 80 0 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("h");
