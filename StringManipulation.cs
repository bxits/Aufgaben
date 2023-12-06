using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben1
{
    class StringManipulation
    {
        public void main()
        {
            string text = "Start manipulation";
            Console.WriteLine(text);

            // Wissen: Ein String besteht aus einem Array aus Charakters
            // schauen wir uns das genauer an und erstellen ein solches Array
            //
            // ToDo: Ersetzen Sie den Namen mit ihrem Namen
            char[] nameArray = { 'F', 'l', 'o', 'r', 'i', 'a', 'n' };

            // Wir weißen dieses Array einem String zu. Da ein String weitere
            // Funktionalität hat, können wir es nicht direkt zuweisen.
            string name = new string(nameArray);

            // Was bedeutet das für unsere Verarbeitung? Damit können wir direkt
            // auf die einzelnen Stellen zugreifen, wenn wir wollen
            Console.WriteLine("Erster Buchstabe deines Vornamens ist:");
            Console.WriteLine(name[0]);

            Console.WriteLine();
            Console.WriteLine("------------1. Aufgabe------------");
            // ToDo: Erzeugen Sie ein Wort aus ihrem Namen, durch umstellen der
            // Buchstaben das Wort muss keinen Sinn ergeben und es müssen nicht
            // alle Buchstaben verwendet werden und Buchstaben dürfen doppelt
            // verwendet werden
            // Hinweis: Buchstaben können mit + aneinandergehängt werden

            // ToDo: Versuchen Sie den "Rückweg", indem Sie den String name
            // in das nameArray überführen und geben Sie das nameArray aus

            Console.WriteLine();
            Console.WriteLine("------------2. Aufgabe------------");
            // Nicht nur Zeichen können, auch Strings können aneinandergehängt werden
            //
            // ToDo: Fügen Sie die Strings text, name und die Zeichenkette " by "
            //       sinnvoll zusammen


            Console.WriteLine();
            Console.WriteLine("------------3. Aufgabe------------");
            // Dieser String kann nicht nur ausgegeben werden. Er kann auch einer
            // Variablen zugewiesen werden.
            //
            // ToDo: Speichern Sie den letzten String in der neuangelegten Variable
            //       tmpText

            // Häufig ist es notwendig, einen String in einzelne Werte oder Wörter
            // zu teilen. Dafür kommt die Methode "Split" zum Einsatz. Dafür benötigt
            // die Methode einen Character, bei dem getrennt werden soll. Das Ergebnis
            // wird in einem String-Array ausgegeben.
            //
            // ToDo: Zerlege den String tmpText in die einzelnen Worte und speichere
            //       die Wörter in dem neuangelegten String-Array tmpWoerter.
            //       Gebe das zweite Wort aus.

            Console.WriteLine();
            Console.WriteLine("------------4. Aufgabe------------");
            // Es gibt in Programmiersprachen zeichen, die bereits durch die Sprache
            // belegt sind. Diese müssen "escaped" werden. Dafür wird das Zeichen \
            // vor das bereits belegte Zeichen vorgestellt. Die Zeichen sind ", ', \
            // diese werden in einem Text so geschrieben \", \', \\
            //
            // ToDo: Fügen Sie die Zeichenkette '1337' (inklusiver der Zeichen ')
            //       zwischen das erste und zweite Wort von tmpWoerter inklusive der
            //       richtig gesetzten Leerzeichen
            
            // ToDo: Geben Sie den Verzeichnispfad aus, in dem ihr Projekt liegt
            
            Console.WriteLine();
            Console.WriteLine("------------5. Aufgabe------------");
            // Der Quellcode lässt sich mit den Escapezeichen nur schlecht lesen und
            // Copy&Paste ist nicht möglich. Dafür gibt es die sogenannten "Verbatim-Strings"
            // Dafür wird ein @-Zeichen vor den String gestellt und dafür werden keine
            // Escapezeichen benötigt. Ausnahme sind die "-Zeichen. Diese müssen verdoppelt
            // werden. Also ein "-Zeichen im Text wird mit "" geschrieben.

            // ToDo: Geben Sie noch einmal das Verzeichnispfad aus und verwenden Sie ein
            //       Verbatim-String
            
            //ToDo: Geben Sie folgenden Text als Verbatim-String aus: Wir geben "-Zeichen
            //      und '-Zeichen aus.

            Console.WriteLine();
            Console.WriteLine("------------6. Aufgabe------------");
            // Manchmal ist es notwendig, einen Platzhalter zu haben. Um während der
            // Programmausführung den String zu verändern können. Dafür wird vor dem String
            // ein $ geschrieben und die Platzhalter werden mit dem Schema {variable}
            // eingesetzt.

            // ToDo: Legen Sie die String-Variable begruessung an und erzeugen Sie einen
            //       String platzhalter, der diese Variable als Platzhalter verwendet. Weisen
            //       Sie der Variable begruessung den Wert "Hallo Welt" zu. Geben Sie im
            //       Anschluss die Variable platzhalter aus

            // ToDo: Verändern Sie den String begruessung in eine andere Sprache (z.B.
            //       Englisch) und geben sie wieder platzhalter aus.
            //       Hat sich die Begrüßung verändert?
            
            // ToDo: Wie könnten wir die neue Begrüßung in den String platzhalter reinbekommen

            Console.WriteLine();
            Console.WriteLine("------------7. Aufgabe------------");
            // Manchmal ist es notwendig Groß- oder Kleinbuchstaben zu haben. Vorallem beim
            // Vergleichen von Buchstaben, wenn Groß- und Kleinschreibung egal ist. Sonst
            // wäre a != A.
            // ToDo: Geben Sie den die Variable begruessung in Klein und in Großbuchstaben aus
            
            Console.WriteLine();
            Console.WriteLine("------------8. Aufgabe------------");
            // Manchmal ist es notwendig nur auf bestimmte Teile des Strings zuzugreifen.
            // ToDo: Führen Sie folgenden Befehl aus und versuchen Sie zu erklären, was er
            //       bewirkt.
            string code = "...asxblattxsa...";
            Console.WriteLine(code.Substring(3, 4));

            // ToDo: Ändern Sie die Ausgabe so ab, dass das Wort blatt herauskommt.
            
            Console.WriteLine();
            Console.WriteLine("------------8. Aufgabe------------");
            // Unser Code besitzt störende Zeichen, die wir bereinigen wollen. Damit wir
            // unerwünschte Zeichen entfernen können, gibt es die Methode Trim(). Trim
            // entfernt am Start und am Ende einer Zeichenkette die mitgegebenen Charakter.
            // dabei ist es egal, wie oft das Zeichen vorhanden ist.
            // Hinweis: TrimEnd und TrimStart werden verwendet, wenn wir nur auf einer Seite
            //          der Zeichenkette die Zeichen entfernen wollen.
            // ToDo: Entfernen Sie mit der Methode Trim() die Zeichen "." und geben Sie das
            //       Ergebnis aus.
            
            // ToDo: Entfernen Sie das Zeichen 'a' am Anfang und dem Ende aus dem String code.
            
            // ToDo: Entfernen Sie das Zeichen 's' und x am Anfang und dem Ende aus dem String code.
            
            Console.WriteLine();
            Console.WriteLine("------------9. Aufgabe------------");
            // manchmal ist es wichtig zu überprüfen, ob eine Zeichenkette in einer anderen
            // enthalten ist. Dafür gibt es die Methode Contains().
            // ToDo.: Überprüfen Sie, ob in dem String text der String "ula" vorhanden ist.
            //        Geben Sie eine Erfolgs- oder Misserfolgs-Meldung aus.

            Console.WriteLine();
            Console.WriteLine("------------10. Aufgabe------------");
            // In anderen Situationen ist es notwendig Zeichen in Zeichenketten zu ersetzen.
            // Dafür wird die Methode Replace() verwendet.
            // ToDo: Ersetzen Sie die Buchstaben folgendermaßen: a -> s, d -> u, r -> c
            //       i -> e
        
        }
    }
}
