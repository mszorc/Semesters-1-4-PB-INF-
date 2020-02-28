all: zad1 zad1-o3 zad2

zad1: zad1.o
	gcc -pthread zad1.o -o zad1
zad1-o3: zad1-o3.o
	gcc -pthread -O3 zad1-o3.o -o zad1-o3
zad2: zad2.o
	gcc -pthread zad2.o -o zad2
zad1.o: zad1.c
	gcc -pthread zad1.c -c -o zad1.o
zad1-o3.o: zad1.c
	gcc -pthread -O3 zad1.c -c -o zad1-o3.o
zad2.o: zad2.c
	gcc -pthread zad2.c -c -o zad2.o

.PHONY: clean
clean:
	rm -f *.o zad1 zad1-o3 zad2
