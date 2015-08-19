#include "dz5.h"



// ISPIS U DATOTEKU
void IspisDat(pokT *glava, double pomeraj, FILE *iz)
{
	double ukP,ukK,sek1,sek2;
	pokT *gl = glava;
	int sat1, min1,sat2,min2;
	char br1[7],br2[7];

	while (glava)
	{
		ukP = glava->pok->sat1 * 3600 + glava->pok->min1 * 60 + glava->pok->sek1 + pomeraj;
		ukK = glava->pok->sat2 * 3600 + glava->pok->min2 * 60 + glava->pok->sek2 + pomeraj;
		
		if (ukP < 0)
			ukP = 0;
		if (ukK < 0)
			ukK = 0;
		sat1 = floor(ukP) / 3600;
		sat2 = floor(ukK) / 3600;
		min1 = floor(ukP - 3600 * sat1) / 60;
		min2 = floor(ukK - 3600 * sat2) / 60;
		sek1 = ukP - 3600 * sat1 - 60 * min1;
		sek2 = ukK - 3600 * sat2 - 60 * min2;

		sprintf(br1, "%06.3f", sek1);
		sprintf(br2, "%06.3f", sek2);
		br1[2] = ',';
		br2[2] = ',';
		
		if ((fprintf(iz, "%d\n%.2d:%.2d:%s --> %.2d:%.2d:%s\n%s\n\n", glava->pok->redni,sat1,min1,br1,sat2,min2,br2, glava->pok->tekst)) < 0)
		{
			printf("Doslo je do greske prilikom upisa u izlaznu datoteku!\n");
			ObrisiListu(gl);
			system("PAUSE");
			exit(6);
		}
		glava = glava->sled;
	}
	
}