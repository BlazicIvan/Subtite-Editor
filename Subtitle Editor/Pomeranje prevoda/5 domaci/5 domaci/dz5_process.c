#include "dz5.h"

pokT* ObrisiListu(pokT *glava)
{
	pokT *pom;
	//printf("\nLista obrisana.\n\n");
	while (glava != NULL)
	{
		pom = glava->sled;
		free(glava->pok);
		free(glava);
		glava = pom;
	}
	return glava;
}