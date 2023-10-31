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
            string[] listeFinMot = { ",", " ", ".", ";", ":", "/", "?", "!", "'", "(", ")", "#", "{", "}", "[", "]", "<", ">", "\\", "_", "&", "\"", "°", "=", "*", "+", "|", "\n", "\r", "" };
            bool finDeMot;
            int occurence;
            List<string> listeMotsDiff = new List<string>() { };
            List<string> listeMotsTotal = new List<string>() { };
            List<string> listeOccurences = new List<string>() { };

            for (int i = 0; i < texteAVerifier.Length; i++)                                                             // vérification sur toutes les lettres du texteAVerifier
            {
                finDeMot = false;                                                                                     // l'état de fin de mot est mis à faux
                for (int j = 0; j < listeFinMot.Length; j++)                                                            // vérification de fin de mot pour chaque lettre du texteAVerifier
                {
                    if (texteAVerifier[i].ToString() == listeFinMot[j])                                               // si la lettre choisie est un des caractères de fin de phrase...
                    {
                        /*if (texteAVerifier[i].ToString() == "'")                                                      // si le caractère trouvé est l'apostrophe...
                        {
                            motTempo += texteAVerifier[i];                                                            // ...rajouter l'apostrophe au mot
                        }*/
                        finDeMot = true;                                                                              // ...détection de fin de phrase, état de fin de mot mis à vrai
                    }
                }
                if (finDeMot == false ||                                                                              // si l'état de fin de mot est à faux...
                    (i == texteAVerifier.Length - 1 && finDeMot == false))                                            // ...OU que la lettre choisie est la dernière du texte (et état fin de mot à faux)...
                {
                    motTempo += texteAVerifier[i];                                                                    // la lettre choisie est ajouté au mot temporaire
                    if (i == texteAVerifier.Length - 1 &&                                                             // si la lettre choisie est la dernière du texte...
                        !listeMotsExclus.Contains(motTempo.ToLower()))                                                // ...et que le mot temporaire n'appartient pas déjà à la liste des mots exclus...
                    {
                        if (!listeMotsDiff.Contains(motTempo.ToLower()))                                              // si le mot temporaire n'appartient pas à la liste des mots différents...
                        {
                            listeMotsDiff.Add(motTempo.ToLower().ToString());                                         // ...l'ajouter à la liste des mots différents
                        }
                        listeMotsTotal.Add(motTempo.ToLower().ToString());                                            // ...l'ajouter à la liste totale des mots
                    }
                }
                else                                                                                                  // sinon...
                {
                    if (motTempo != "" &&                                                                             // si le mot temporaire n'est pas vide...
                        !listeMotsExclus.Contains(motTempo.ToLower()))                                                // ...ET que le mot temporaire n'appartient pas à la liste des mots exclus...
                    {
                        if (!listeMotsDiff.Contains(motTempo.ToLower()))                                              // si le mot temporaire n'appartient pas à la liste des mots différents...
                        {
                            listeMotsDiff.Add(motTempo.ToLower().ToString());                                         // ...l'ajouter à la liste des mots différents
                        }
                        listeMotsTotal.Add(motTempo.ToLower().ToString());                                            // ...l'ajouter à la liste totale des mots
                    }
                    motTempo = "";                                                                                    // et rendre le mot temporaire vide
                }
            }
            foreach (string mot1 in listeMotsDiff)                                                                    // pour chaque mot dans la liste des mots différents...
            {
                occurence = 0;                                                                                        // nombre d'occurences du mot choisi mis à 0
                for (int k = 0; k < listeMotsTotal.Count; k++)                                                          // pour chaque mot dans la liste totale des mots...
                {
                    if (mot1 == listeMotsTotal[k])                                                                    // ...si le mot de la liste totale des mots correspond au mot choisi...
                    {
                        occurence++;                                                                                  // ...incrément du nombre d'occurence du mot choisi
                    }
                }
                listeOccurences.Add(occurence.ToString());                                                            // ajout de la valeur d'occurence du mot à la liste d'occurence
            }
            texteNbTotalMots.Text = listeMotsTotal.Count.ToString();                                     // affichage du nombre total de mots trouvés
            texteNbDiffMots.Text = listeMotsDiff.Count.ToString();                                // ,affichage du nombre de mots différents trouvés
                                                                                                  // et affichage de la liste des mots différents :
            for (int f = 0; f < listeMotsDiff.Count; f++)                                                               // pour chaque mot dans la liste des mots différents...
            {
                texteDeFin += ("(" + listeOccurences[f] + "x) (" +                                                 // affichage du nombre d'occurences associé au mot
                                    Math.Round((100.0 / ((double)listeMotsTotal.Count /                                    // et affichage du pourcentage d'apparition
                                    Int32.Parse(listeOccurences[f]))), 2) +                                             // du mot dans le texte
                                    "%) " + listeMotsDiff[f]) + Environment.NewLine;                                                      // ,puis affichage du mot
            }
            textboxResultat.Text = texteDeFin;            
        }
    }
}