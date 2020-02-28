function [y] = Zad4Funkcja(x)
    l = length(x);
    y(1) = 0.25 * x(1);
    y(2) = 0.5 * x(1) + 0.25 * x(2);
    i = 3;
    while (i <= l)
        y(i) = 0.25 * x(i-2) + 0.5 * x(i-1) + 0.25 * x(i);
        i = i + 1;
    end
end