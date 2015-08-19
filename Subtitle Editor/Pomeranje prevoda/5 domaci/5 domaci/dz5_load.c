#include "dz5.h"

// UNOS LISTE
pokT* Unos(pokT *glava, FILE *ul)
{
	int i, flag = 1,end=0;
	pokT *pom, *temp;
	double p, k;
	char c[MAX_LEN],kar;
	titl *polje;
	int sat1, min1, sat2, min2, red, s1,s2,ss1,ss2 ;

	while ((fscanf(ul, "%d %d:%d:%d,%d --> %d:%d:%d,%d", &red,&sat1,&min1, &s1,&s2,&sat2,&min2, &ss1,&ss2)) != EOF)
	{
		polje = malloc(sizeof(titl));

		if (polje == NULL) //greska pri alociranju
		{
			printf("Greska pri alokaciji memorije!\n");
			glava = ObrisiListu(glava);
			system("PAUSE");
			exit(4);
		}
		p = (1000 * s1 + 1.0*s2) / 1000;
		k = (1000 * ss1 + 1.0*ss2) / 1000;

		polje->sat1 = sat1;
		polje->sat2 = sat2;
		polje->redni = red;
		polje->min1 = min1;
		polje->min2 = min2;
		polje->sek1 = p;
		polje->sek2 = k;


		if((fgetc(ul))==EOF)
			break;

		strcpy(polje->tekst, "");

		while (1)
		{
			if (fgets(c, MAX_LEN, ul) == NULL)
			{
				end = 1;
				break;
			}
			if (strcmp(c,"\n")==0)
				break;
			strcat(polje->tekst, c);
		}
		polje->tekst[strlen(polje->tekst) - 1] = '\0';

		pom = malloc(sizeof(pokT));
		if (pom == NULL) //greska pri alociranju
		{
			printf("Greska pri alokaciji memorije!\n");
			glava = ObrisiListu(glava);
			system("PAUSE");
			exit(4);
		}

		pom->pok = polje;

		if (glava == NULL)
		{
			glava = pom;
			glava->sled = glava->pred = NULL;
		}
		else
		{
			if (flag)
			{
				temp = glava;
				flag = 0;
			}
			pom->pred = temp;
			pom->sled = NULL;
			temp->sled = pom;
			temp = temp->sled;
		}

		if (end)
			break;
	}
	
	return glava;
}


