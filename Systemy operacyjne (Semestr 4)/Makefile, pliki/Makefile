OBJ = main.c read.c
all: readfile
readfile: $(OBJ)
	gcc $(OBJ) -o readfile
$(OBJ): read.h
.PHONY: clean
clean:
	rm -f *.o makefile 




