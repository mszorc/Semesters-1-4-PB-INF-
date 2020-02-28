function y = myifft(x)
len = length(x);
y=x*inv(dftmtx(len));
end