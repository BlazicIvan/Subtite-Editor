#include "dz5.h"

void main(int argc, char* argv[])
{
	FILE *ul, *iz;
	pokT *glava = NULL;
	char ulazD[150], izlazD[100];
	double uk;

	strcpy(ulazD,"Primer.srt");
	strcpy(izlazD, "Izlaz.srt");

	// PROVERA ISPRAVNOSTI ARGUMENATA
	Provera(ulazD, izlazD, &ul, &iz);
	//UNOS,ISPIS,BRISANJE
	printf("Unesite vrednost pomeraja:\n");
	scanf("%lf", &uk);

	glava = Unos(glava, ul);
	IspisDat(glava, uk, iz);
	glava=ObrisiListu(glava);
	
	printf("\nObrada je uspesno zavrsena!\n\n");

	system("PAUSE");
}
