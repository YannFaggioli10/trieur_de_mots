namespace trieur_de_mots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boutonCheck_Click(object sender, EventArgs e)
        {
            string texteAVerifier = textboxTexte.Text;
            List<string> listeMotsExclus = new List<string>() { };
            string motTempo = "", texteDeFin = "";
            string[] listeFinMot = { ",", " ", ".", ";", ":", "/", "?", "!", "'", "(", ")", "#", "{", "}", "[", "]", "<", ">", "\\", "_", "&", "\"", "�", "=", "*", "+", "|", "\n", "\r", "" };
            bool finDeMot;
            int occurence;
            List<string> listeMotsDiff = new List<string>() { };
            List<string> listeMotsTotal = new List<string>() { };
            List<string> listeOccurences = new List<string>() { };

            for (int i = 0; i < texteAVerifier.Length; i++)                                                             // v�rification sur toutes les lettres du texteAVerifier
            {
                finDeMot = false;                                                                                     // l'�tat de fin de mot est mis � faux
                for (int j = 0; j < listeFinMot.Length; j++)                                                            // v�rification de fin de mot pour chaque lettre du texteAVerifier
                {
                    if (texteAVerifier[i].ToString() == listeFinMot[j])                                               // si la lettre choisie est un des caract�res de fin de phrase...
                    {
                        /*if (texteAVerifier[i].ToString() == "'")                                                      // si le caract�re trouv� est l'apostrophe...
                        {
                            motTempo += texteAVerifier[i];                                                            // ...rajouter l'apostrophe au mot
                        }*/
                        finDeMot = true;                                                                              // ...d�tection de fin de phrase, �tat de fin de mot mis � vrai
                    }
                }
                if (finDeMot == false ||                                                                              // si l'�tat de fin de mot est � faux...
                    (i == texteAVerifier.Length - 1 && finDeMot == false))                                            // ...OU que la lettre choisie est la derni�re du texte (et �tat fin de mot � faux)...
                {
                    motTempo += texteAVerifier[i];                                                                    // la lettre choisie est ajout� au mot temporaire
                    if (i == texteAVerifier.Length - 1 &&                                                             // si la lettre choisie est la derni�re du texte...
                        !listeMotsExclus.Contains(motTempo.ToLower()))                                                // ...et que le mot temporaire n'appartient pas d�j� � la liste des mots exclus...
                    {
                        if (!listeMotsDiff.Contains(motTempo.ToLower()))                                              // si le mot temporaire n'appartient pas � la liste des mots diff�rents...
                        {
                            listeMotsDiff.Add(motTempo.ToLower().ToString());                                         // ...l'ajouter � la liste des mots diff�rents
                        }
                        listeMotsTotal.Add(motTempo.ToLower().ToString());                                            // ...l'ajouter � la liste totale des mots
                    }
                }
                else                                                                                                  // sinon...
                {
                    if (motTempo != "" &&                                                                             // si le mot temporaire n'est pas vide...
                        !listeMotsExclus.Contains(motTempo.ToLower()))                                                // ...ET que le mot temporaire n'appartient pas � la liste des mots exclus...
                    {
                        if (!listeMotsDiff.Contains(motTempo.ToLower()))                                              // si le mot temporaire n'appartient pas � la liste des mots diff�rents...
                        {
                            listeMotsDiff.Add(motTempo.ToLower().ToString());                                         // ...l'ajouter � la liste des mots diff�rents
                        }
                        listeMotsTotal.Add(motTempo.ToLower().ToString());                                            // ...l'ajouter � la liste totale des mots
                    }
                    motTempo = "";                                                                                    // et rendre le mot temporaire vide
                }
            }
            foreach (string mot1 in listeMotsDiff)                                                                    // pour chaque mot dans la liste des mots diff�rents...
            {
                occurence = 0;                                                                                        // nombre d'occurences du mot choisi mis � 0
                for (int k = 0; k < listeMotsTotal.Count; k++)                                                          // pour chaque mot dans la liste totale des mots...
                {
                    if (mot1 == listeMotsTotal[k])                                                                    // ...si le mot de la liste totale des mots correspond au mot choisi...
                    {
                        occurence++;                                                                                  // ...incr�ment du nombre d'occurence du mot choisi
                    }
                }
                listeOccurences.Add(occurence.ToString());                                                            // ajout de la valeur d'occurence du mot � la liste d'occurence
            }
            texteNbTotalMots.Text = listeMotsTotal.Count.ToString();                                     // affichage du nombre total de mots trouv�s
            texteNbDiffMots.Text = listeMotsDiff.Count.ToString();                                // ,affichage du nombre de mots diff�rents trouv�s
                                                                                                  // et affichage de la liste des mots diff�rents :
            for (int f = 0; f < listeMotsDiff.Count; f++)                                                               // pour chaque mot dans la liste des mots diff�rents...
            {
                texteDeFin += ("(" + listeOccurences[f] + "x) (" +                                                 // affichage du nombre d'occurences associ� au mot
                                    Math.Round((100.0 / ((double)listeMotsTotal.Count /                                    // et affichage du pourcentage d'apparition
                                    Int32.Parse(listeOccurences[f]))), 2) +                                             // du mot dans le texte
                                    "%) " + listeMotsDiff[f]) + Environment.NewLine;                                                      // ,puis affichage du mot
            }
            textboxResultat.Text = texteDeFin;            
        }
    }
}