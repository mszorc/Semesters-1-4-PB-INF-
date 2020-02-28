N=1024;
fs=8000;
n=linspace(1,N,N);
f1=500;
f2=1200;
w=randn(1,1024);
s = 0.5*sin(2*pi*n*f1/fs)+sin(2*pi*n*f2/fs);
y=s+0.1*w;
[pw,a] = periodogram(w);
[ps,b] = periodogram(s);
[py,c] = periodogram(y);
subplot(3,2,1);
plot(a/pi,10*log10(pw));
xlabel('Normalized frequency (\times\pi rad/sample)');
ylabel('Power/frequency (dB/rad/sample)');
title('Periodogram Power Spectral Density Estimate');
subplot(3,2,3);
plot(b/pi,10*log10(ps));
xlabel('Normalized frequency (\times\pi rad/sample)');
ylabel('Power/frequency (dB/rad/sample)');
title('Periodogram Power Spectral Density Estimate');
subplot(3,2,5);
plot(c/pi,10*log10(py));
xlabel('Normalized frequency (\times\pi rad/sample)');
ylabel('Power/frequency (dB/rad/sample)');
title('Periodogram Power Spectral Density Estimate');

[pw,a] = periodogram(w,hann(length(w),'symmetric'));
[ps,b] = periodogram(s,hann(length(s),'symmetric'));
[py,c] = periodogram(y,hann(length(y),'symmetric'));
subplot(3,2,2);
plot(a/pi,10*log10(pw));
xlabel('Normalized frequency (\times\pi rad/sample)');
ylabel('Power/frequency (dB/rad/sample)');
title('Periodogram Power Spectral Density Estimate');
subplot(3,2,4);
plot(b/pi,10*log10(ps));
xlabel('Normalized frequency (\times\pi rad/sample)');
ylabel('Power/frequency (dB/rad/sample)');
title('Periodogram Power Spectral Density Estimate');
subplot(3,2,6);
plot(c/pi,10*log10(py));
xlabel('Normalized frequency (\times\pi rad/sample)');
ylabel('Power/frequency (dB/rad/sample)');
title('Periodogram Power Spectral Density Estimate');

[pw,a] = pwelch(w,hann(256,'symmetric'),0.5,[],fs);
[ps,b] = pwelch(w,hann(128,'symmetric'),0.5,[],fs);
[py,c] = pwelch(w,hann(64,'symmetric'),0.5,[],fs);
figure
hold on
plot(a,pow2db(pw));
plot(b,pow2db(ps));
plot(c,pow2db(py));
xlabel('Frequency (Hz)');
ylabel('PSD (dB/Hz)');
title('Szum gaussowski - Perdiodogram Welscha');
legend('NFFT = 256','NFFT = 128','NFFT = 64')
hold off

[pw,a] = pwelch(s,hann(256),0.5,[],fs);
[ps,b] = pwelch(s,hann(128),0.5,[],fs);
[py,c] = pwelch(s,hann(64),0.5,[],fs);
figure
hold on
plot(a,pow2db(pw));
plot(b,pow2db(ps));
plot(c,pow2db(py));
xlabel('Frequency (Hz)');
ylabel('PSD (dB/Hz)');
title('Sygnaly sinusoidalne - Perdiodogram Welscha');
legend('NFFT = 256','NFFT = 128','NFFT = 64')
hold off

[pw,a] = pwelch(y,hann(256),0.5,[],fs);
[ps,b] = pwelch(y,hann(128),0.5,[],fs);
[py,c] = pwelch(y,hann(64),0.5,[],fs);
figure
hold on
plot(a,pow2db(pw));
plot(b,pow2db(ps));
plot(c,pow2db(py));
xlabel('Frequency (Hz)');
ylabel('PSD (dB/Hz)');
title('Sygna³y w szumie - Perdiodogram Welscha');
legend('NFFT = 256','NFFT = 128','NFFT = 64')
hold off

