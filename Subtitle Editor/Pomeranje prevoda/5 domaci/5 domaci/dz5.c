#include "dz5.h"

void main(int argc, char* argv[])
{
	FILE *ul, *iz;
	pokT *glava = NULL;
	double uk = (double)atof(argv[1]); //vrednost pomeraja

	if ((ul = fopen(argv[2], "r")) == NULL)
	{
		printf("Greska pri otvaranju ulazne datoteke!\n");
		system("PAUSE");
		exit(1);
	}

	glava = Unos(glava, ul);    /*unos datoteke u listu*/

	//zatvaranje datoteke
	if (fclose(ul) == EOF)
	{
		printf("Greska pri zatvaranju ulazne datoteke!\n");
		system("PAUSE");
		glava = ObrisiListu(glava);
		exit(5);
	}

	if ((iz = fopen(argv[2], "w")) == NULL)
	{
		printf("Greska pri otvaranju izlazne datoteke!\n");
		system("PAUSE");
		glava = ObrisiListu(glava);
		exit(2);
	}

	IspisDat(glava, uk, iz);   /*upis obradjenog titla u datoteku*/

	if (fclose(iz) == EOF)
	{
		printf("Greska pri zatvaranju izlazne datoteke!\n");
		system("PAUSE");
		glava = ObrisiListu(glava);
		exit(5);
	}

	glava = ObrisiListu(glava);    /*brisanje liste*/
	

	printf("\nObrada je uspesno zavrsena!\n\n");
	system("PAUSE");
	exit(0);
}
