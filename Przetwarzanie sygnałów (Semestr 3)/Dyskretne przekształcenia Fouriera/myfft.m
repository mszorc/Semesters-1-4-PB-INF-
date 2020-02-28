function y  = myfft(x)
len = length(x);
y=x*dftmtx(len);
end