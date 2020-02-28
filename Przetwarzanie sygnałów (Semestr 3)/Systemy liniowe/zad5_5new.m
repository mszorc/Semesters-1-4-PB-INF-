[anechoic,fs0] = audioread('anechoic.wav');
[impulse,fs1] = audioread('impulse.wav');
[impulse2,fs2] = audioread('impulse2.wav');
t=0:1/fs0:5-1/fs0;
y = anechoic(1:5*fs0,1);
impone = impulse(:,1);
impone = impone';
imptwo = impulse2(:,1);
imptwo = imptwo';
imp1=[impone zeros(1,length(y)-length(impone))];
imp1 = imp1';
imp2=[imptwo zeros(1,length(y)-length(imptwo))];
imp2 = imp2';
con1 = ifft(fft(y).*fft(imp1));
con2 = ifft(fft(y).*fft(imp2));
figure
subplot(3,1,1);
plot(t,y);
ylabel('Amplituda');
xlabel('Czas [sek.]');
title('Sygna� mowy nagrany w komorze bezechowej');
subplot(3,1,2);
plot(t,imp1);
ylabel('Amplituda');
xlabel('Czas [sek.]');
title('Akustyczna odpowied� impulsowa z sali koncertowej');
subplot(3,1,3);
plot(t,con1);
ylabel('Amplituda');
xlabel('Czas [sek.]');
title('Splot nagrania d�wiekowego z komory bezechowej z akustyczna odpowiedzi� impulsow� z sali koncertowej');
figure
subplot(3,1,1);
plot(t,y);
ylabel('Amplituda');
xlabel('Czas [sek.]');
title('Sygna� mowy nagrany w komorze bezechowej');
subplot(3,1,2);
plot(t,imp2);
ylabel('Amplituda');
xlabel('Czas [sek.]');
title('Akustyczna odpowied� impulsowa z korytarza');
subplot(3,1,3);
plot(t,con2);
ylabel('Amplituda');
xlabel('Czas [sek.]');
title('Splot nagrania d�wiekowego z komory bezechowej z akustyczn� odpowiedzi� impulsowa z korytarza');