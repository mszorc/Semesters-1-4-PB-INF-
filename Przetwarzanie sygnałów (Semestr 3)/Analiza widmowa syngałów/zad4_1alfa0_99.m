fs=8000;
time=5;
alf=0.99;
t=0:1/fs:time-1/fs;
gauss = randn(1,time*fs);
fsin = 1000;
sinusoida = sin(2*pi*fsin*t);
signal = chirp(t,0,5,1000);
[voice,fn] = audioread('www.wav');

obsin=sinusoida;
obsin(1)=(alf-1)*sinusoida(1);
for n = 2:fs*time
  obsin(n) = alf*obsin(n-1)+(alf-1)*sinusoida(n)^2;
end
obgauss(1)=(alf-1)*gauss(1);
for n = 2:fs*time
  obgauss(n) = alf*obgauss(n-1)+(alf-1)*gauss(n)^2;
end
obsignal(1)=(alf-1)*signal(1);
for n = 2:fs*time
  obsignal(n) = alf*obsignal(n-1)+(alf-1)*signal(n)^2;
end
obvoice(1)=(alf-1)*voice(1);
for n = 2:fs*time
  obvoice(n) = alf*obvoice(n-1)+(alf-1)*voice(n)^2;
end
subplot(4,2,1);
plot(t,gauss);
axis([-inf inf -5 5]);
xlabel('Czas [s]');
ylabel('Amplituda');
title('Szum gaussowski');
subplot(4,2,2);
plot(t,(-1)*obgauss);
axis([-inf inf 0 2]);
xlabel('Czas [s]');
ylabel('Moc');
title('Szum gaussowski - Obwiednia mocy, \alpha = 0.99');
subplot(4,2,3);
plot(t,sinusoida);
xlabel('Czas [s]');
ylabel('Amplituda');
title('Sygna³ sinusoidalny o sta³ej czêstotliwoœci');
subplot(4,2,4);
plot(t,(-1)*obsin);
axis([-inf inf 0 1]);
xlabel('Czas [s]');
ylabel('Moc');
title('Syga³ sinusoidalny - Obwiednia mocy, \alpha = 0.99');
subplot(4,2,5);
plot(t,signal);
xlabel('Czas [s]');
ylabel('Amplituda');
title('Sygna³ o zmiennej czêstotliwoœci');
subplot(4,2,6);
plot(t,(-1)*obsignal);
axis([-inf inf 0 1]);
xlabel('Czas [s]');
ylabel('Moc');
title('Sygna³ o zmiennej czêstotliwoœci - Obwiednia mocy, \alpha = 0.99');
subplot(4,2,7);
plot(t,voice);
xlabel('Czas [s]');
ylabel('Amplituda');
title('Sygna³ mowy');
subplot(4,2,8);
plot(t,(-1)*obvoice);
axis([-inf inf 0 0.2]);
xlabel('Czas [s]');
ylabel('Moc');
title('Sygna³ mowy - Obwiednia mocy \alpha = 0.99');