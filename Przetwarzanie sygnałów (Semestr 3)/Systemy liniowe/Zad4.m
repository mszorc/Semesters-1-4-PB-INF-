N=64;
n=0:1:N-1;
x1=sin(2*pi*n/N);
h=exp(-n/10);
x1fft=fft(x1);
hfft=fft(h);
g=x1fft.*hfft;
figure
subplot(2,2,1)
stem(n,x1);
axis([0 130 -1 1]);
xlabel("Numer pr�bki");
ylabel("Amplituda");
title("Pobudzenie - Sygna� sinusoidalny");
subplot(2,2,2)
stem(conv(x1,h));
xlabel("Numer pr�bki");
ylabel("Amplituda");
title("Splot ko�owy x1[n]*h[n]");
subplot(2,2,3)
stem(n,h);
axis([0 130 0 1]);
xlabel("Numer pr�bki");
ylabel("Amplituda");
title("Odpowied� impulsowa");
subplot(2,2,4)
stem(ifft(g));
axis([0 130 -8 8]);
xlabel("Numer pr�bki");
ylabel("Amplituda");
title("IDFT{X1[k}H[k]}");