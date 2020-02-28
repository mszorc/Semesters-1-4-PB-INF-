function [output] = S3(input)
  l=length(input)-1;
  K=1;
  while (K <= l)
    output(K)=input(K+1)-input(K);
    K = K + 1;
  end
end