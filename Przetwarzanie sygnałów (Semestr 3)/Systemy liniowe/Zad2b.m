N=64;
n=0:1:N-1;
k=16;
x1=sin(2*pi*n/N);
x2=sin(4*pi*n/N);
h=double(kroneckerDelta(sym(n), k));

figure
subplot(3,3,1);
plot(n,x1);
axis([0 80 -1 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x1");

subplot(3,3,2);
plot(conv(x1,h));
axis([0 150 -1 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Splot liniowy x1*h");

subplot(3,3,3);
plot(cconv(x1,h));
axis([0 150 -1 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Splot ko³owy x1*h");

subplot(3,3,4);
plot(n,x2);
axis([0 80 -1 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("x2");

subplot(3,3,5);
plot(conv(x2,h));
axis([0 150 -1 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Splot liniowy x2*h");

subplot(3,3,6);
plot(cconv(x2,h));
axis([0 150 -1 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Splot ko³owy x2*h");

subplot(3,3,7);
stem(n,h);
axis([0 64 0 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("h");

subplot(3,3,8);
plot(conv(x1,x2));
axis([0 150 -10 10]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Splot liniowy x1*x2");

subplot(3,3,9);
plot(cconv(x1,x2));
axis([0 150 -10 10]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Splot ko³owy x1*x2");