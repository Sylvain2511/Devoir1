using System;

namespace ModelObjet
{
    public class Condition
    {
        const int nbJours = 30;
        // Permet de savoir si on a le droit d'être remboursé
        // On l'est à condition que le nombre de jours ne dépasse pas 30 !
        public static bool Valider(int unNbDeJours)
        {
            if(unNbDeJours < 30)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        // Permet de renvoyer le montant MAX remboursé en fonction de la catégorie
        public static int CalculerMontantMax(string uneCategorie)
        {
            int montantMax = 0;
            string unLivre = "Livres";
            string unJouet = "LesJouets";
            string Informatique = "Informatique";
            if(uneCategorie == unLivre)
            {
                montantMax = 30;
                return montantMax;
            }
            if(uneCategorie == unJouet)
            {
                montantMax = 50;
                return montantMax;
            }
            if (uneCategorie == Informatique)
            {
                montantMax = 1000;
                return montantMax;
            }
            return montantMax;
        }
        // Permet de retourner le total remboursé en fonction de tous les critères
        public static double CalculerMontantRembourse(int unNbDeJours, string uneCategorie, bool estMembre, string unEtat, int unPrix)
        {
            double montantRembourse = 0;
            double taux = 0;
            if(Valider(unNbDeJours) == true)
            {
                if (unPrix < CalculerMontantMax(uneCategorie))
                {
                    if (estMembre == true)
                    {
                        
                    }
                    else
                    {
                        taux = 0.2;
                    }
                }
                
            }
            else
            {
                return montantRembourse = 0;
            }
            return Math.Round(unPrix * (1-taux),2);

        }
        // Permet de renvoyer la réduction si on est membre ou pas
        public static double CalculerReductionMembre(bool estMembre)
        {
            double reductionMembre = 0;
            
            if (estMembre == true)
            {
                reductionMembre = 0;
            }
            else
            {
                reductionMembre = 0.20;
            }
            return reductionMembre;
        }
        // Permet de renvoyer la réduction en fonction de l'état de l'achat
        public static double CalculerReduction(string unEtat)
        {
            double tauxReduction = 0;
            
            if (unEtat == "Abimé" || unEtat == "Très abimé")
            {
                tauxReduction = 0.30;
            }
            if(unEtat == "Bon" || unEtat == "Très bon")
            {
                tauxReduction = 0.10;
            }
            
            return tauxReduction;
        }
    }
}
