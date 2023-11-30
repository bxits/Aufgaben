Aufgabe 1
Lesen Sie eine Zeile von der Konsole ein und geben Sie diese direkt wieder aus.

Aufgabe 2
Lesen Sie zwei Zeilen von der Konsole ein und verketten Sie beide Eingabezeilen und geben Sie diese als eine Zeichenkette wieder aus.

Aufgabe 3
Lesen Sie den Benutzernamen ein und geben Sie eine Begrüßungsformel "Hallo (Benutzername), wie geht's?" wieder aus.


Aufgabe 4
Lesen Sie zwei Zahlen ein und addieren Sie beide. Geben Sie das Ergebnis auf der Konsole aus.

Aufgabe G1
Lesen Sie Ganzzahlen und Zeichenfolgen von der Oberfläche ein. Geben Sie aus, ob sich die Eingaben in Ganzzahlen umwandeln lassen. Verwenden Sie folgenden Code, den Sie noch anpassen müssen:
int n;
bool isNumeric = int.TryParse("11", out n);

Aufgabe D1
Lesen Sie Dezimalzahlen und Zeichenfolgen von der Oberfläche ein. Geben Sie aus, ob sich die Eingaben in Dezimalzahlen umwandeln lassen. Verwenden Sie folgenden Code, den Sie noch anpassen müssen:
double n;
bool isNumeric = double.TryParse("11", out n);

Aufgabe G1D1
Kombinieren Sie Aufgabe G1 und Aufgabe D1

Aufgabe 5
Mini-Rechner
Lesen Sie zwei Zahlenwerte von der Konsole ein.
Fragen Sie vom Benutzer ab, ob er "+", "-", ":" oder "*" rechnen will.
Führen Sie die entsprechende Rechnung aus.

Aufgabe Zahlenraten
Generieren Sie eine Zufallszahl mit
Random rnd = new Random();
int zufallsZahl = rnd.Next(1,11) //Eine Zufallszahl zwischen 1 und 10 (mit der 1, ohne die 11)

Lassen Sie den Benutzer eine Zahl eingeben und überprüfen Sie, ob der Benutzer diese Zahl erraten hat.

Aufgabe Ausgabeschleife
Lesen Sie eine Zeichnkette ein. Lesen Sie danach eine Zahl ein. Die Zeichenkette soll so oft wie die Zahl vorgibt ausgegeben werden. Verwenden Sie hierfür eine for-Schleife.

Aufgabe Zahlenraten endlos
Erweitern Sie das Zahlenraten-Spiel um folgende Funktionalität:
Das Programm soll immer wieder von vorne anfangen. Nur wenn der Benutzer ein 'x' eingibt, soll das Programm beendet werden.

Aufgabe Array1
Erstellen Sie ein Array mit Platz für 100 Ganzzahlen. Füllen Sie das Array komplett mit Zufallszahlen (siehe Aufgabe Zahlenraten) mittels einer for-Schleife (oder foreach-Schleife).
Geben Sie das Array auf der Konsole aus.

Aufgabe Array2
Machen Sie dasselbe wie unter der Aufgabe Array1, nur für Kommazahlen. Erzeugen Sie Zahlen mit Nachkommastellen durch Division.

Aufgabe Array3
Erstellen Sie ein String-Array mit 10 Stellen. Bieten Sie dem Benutzer, die Möglichkeit, die Zeichenketten im Array zu ändern. Geben Sie nach der Änderung das gesamte Array aus.

Aufgabe Array4
Erstellen Sie ein Ganzzahlen-Array mit 10.000 Stellen und befüllen Sie dieses mit Zufallszahlen zwischen 0 und 100. Ermitteln sie die Häufigkeit jeder einzelnen Zahl und geben Sie diese aus.

[ToDo] 
Aufgaben zu String-Manipilation Split(), string as char[], Trim(), Concat, @, $-Interpolation
Aufgaben zu Datei-Zugriff mit Streams. Schreiben, Lesen. Modes CRUD

