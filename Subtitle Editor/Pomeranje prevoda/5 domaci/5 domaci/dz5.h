
#ifndef MAX_LEN

#define MAX_LEN 300

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <time.h>


typedef struct
{
	double sek1, sek2;
	int redni, sat1, min1, sat2, min2;
	char tekst[MAX_LEN];
}titl;

typedef struct elem
{
	struct elem *pred, *sled;
	titl *pok;
}pokT;


pokT* Unos(pokT *glava, FILE *ul);

pokT* ObrisiListu(pokT *glava);

void IspisDat(pokT *glava, double pomeraj, FILE *iz);


#endif