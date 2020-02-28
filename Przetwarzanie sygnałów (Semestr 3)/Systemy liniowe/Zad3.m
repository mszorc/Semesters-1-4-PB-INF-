N=64;
n=1:1:N;
k=1;
h=double(kroneckerDelta(sym(n), k));
y=sin(2*pi*n/N);
figure
subplot(2,2,1)
stem(n,h);
axis([0 80 0 1]);
xlabel("Numer probki");
ylabel("Amplituda");
title("Pobudzenie - impuls");
subplot(2,2,2)
stem(n,y);
xlabel("Numer probki");
ylabel("Amplituda");
title("Pobudzenie - synga≥ sinusoidalny");
subplot(2,2,3)
stem(Zad4Funkcja(h));
xlabel("Numer probki");
ylabel("Amplituda");
title("Odpowiedü impulsowa");
subplot(2,2,4)
stem(Zad4Funkcja(y));
xlabel("Numer probki");
ylabel("Amplituda");
title("Odpowiedü na pobudzenie sinusoidalne");