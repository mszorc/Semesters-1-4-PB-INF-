N=32
n=linspace(1,N,N)
y=sin(2*pi*n/N*2.5)
yfft=2*fft(y)/N
 
figure
subplot(2,1,1)
stem(n,y)
title('y')
xlabel('Numer Probki')
ylabel('Amplituda')
subplot(2,1,2)
stem(abs(yfft))
axis([0 33 0 1])
title('Modul FFT - Brak Okna')
xlabel('Numer Pasma Czestotliwosciowego')
ylabel('Magnituda')
 
y = y(:)
w1=window(@bartlett,N)
y1=y.*w1
y1fft=2*fft(y1)/N
w2=window(@blackman,N)
y2=y.*w2
y2fft=2*fft(y2)/N
w3=window(@hamming,N)
y3=y.*w3
y3fft=2*fft(y3)/N
w4=window(@hann,N)
y4=y.*w4
y4fft=2*fft(y4)/N
w5=window(@kaiser,N)
y5=y.*w5;
y5fft=2*fft(y5)/N
w6=window(@rectwin,N)
y6=y.*w6
y6fft=2*fft(y6)/N
 
 
figure
subplot(2,3,1)
stem(abs(y1fft))
title('Modul FFT - Bartlett')
xlabel('Numer Pasma Czestotliwosciowego')
ylabel('Magnituda')
subplot(2,3,2)
stem(abs(y2fft))
title('Modul FFT - Blackman')
xlabel('Numer Pasma Czestotliwosciowego')
ylabel('Magnituda')
subplot(2,3,3)
stem(abs(y3fft))
title('Modul FFT - Hamming')
xlabel('Numer Pasma Czestotliwosciowego')
ylabel('Magnituda')
subplot(2,3,4)
stem(abs(y4fft))
title('Modul FFT - Hann')
xlabel('Numer Pasma Czestotliwosciowego')
ylabel('Magnituda')
subplot(2,3,5)
stem(abs(y5fft))
title('Modul FFT - Kaiser')
xlabel('Numer Pasma Czestotliwosciowego')
ylabel('Magnituda')
subplot(2,3,6)
stem(abs(y6fft))
title('Modul FFT - Rectwin')
xlabel('Numer Pasma Czestotliwosciowego')
ylabel('Magnituda')
 
wvtool(w1,w2,w3,w4,w5,w6);
