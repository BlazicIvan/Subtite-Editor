#include "dz5.h"



// PROVERA DA LI JE SVE ISPRAVNO
void Provera(char *s1, char *s2, FILE **ul, FILE **iz)
{
	if ((*ul = fopen(s1, "r")) == NULL)
	{
		printf("Greska pri otvaranju ulazne datoteke!\n");
		system("PAUSE");
		exit(1);
	}

	if ((*iz = fopen(s2, "w")) == NULL)
	{
		printf("Greska pri otvaranju izlazne datoteke!\n");
		system("PAUSE");
		exit(2);
	}

}


