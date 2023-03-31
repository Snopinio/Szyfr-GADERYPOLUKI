string gaderypuluki(string clearText)
{
    //zmiennna do przechowywania zaszyfrowanego tekstu
    //zapisujemy czysty tekst do dalszego zaszyfrowania
    string cypherText = clearText;
    //zamien G na A i zapisz do nowaej zmiennej
    cypherText = cypherText.Replace('G', '@');
    //wez juz czesciowo zaszyfrowny teskt i zamien A na G
    //uzyj znaku posredniego aby zapobiec dwukrotnej zamianie jeden litery
    cypherText = cypherText.Replace('A', 'G');
    cypherText = cypherText.Replace('@', 'A');
    //d->e, e->d
    cypherText = cypherText.Replace('D', '@');
    cypherText = cypherText.Replace('E', 'D');
    cypherText = cypherText.Replace('@', 'E');
    //r->y, y->r
    cypherText = cypherText.Replace('R', '@');
    cypherText = cypherText.Replace('Y', 'R');
    cypherText = cypherText.Replace('@', 'Y');
    //p->o, o->p
    cypherText = cypherText.Replace('P', '@');
    cypherText = cypherText.Replace('O', 'P');
    cypherText = cypherText.Replace('@', 'O');
    //l->u, u->l
    cypherText = cypherText.Replace('L', '@');
    cypherText = cypherText.Replace('U', 'L');
    cypherText = cypherText.Replace('@', 'U');
    //k->i, i->k
    cypherText = cypherText.Replace('K', '@');
    cypherText = cypherText.Replace('I', 'K');
    cypherText = cypherText.Replace('@', 'I');

    return cypherText;
}

string gaderypoluki2(string clearText)
{
    string cypherText = "";

    foreach (char c in clearText)
    {
        //wyonaj ponizsze instrucje dla kazdej itery w tekscie zrodloym
        // c = jedna literka z tekstu
        switch(c)
        {
            case 'G':
                cypherText += "A";
                break;
            case 'A':
                cypherText += "G";
                break;
            case 'D':
                cypherText += "E";
                break;
            case 'E':
                cypherText += "D";
                break;
            case 'R':
                cypherText += "Y";
                break;
            case 'Y':
                cypherText += "R";
                break;
            case 'P':
                cypherText += "O";
                break;
            case 'O':
                cypherText += "P";
                break;
            case 'L':
                cypherText += "U";
                break;
            case 'U':
                cypherText += "L";
                break;
            case 'K':
                cypherText += "I";
                break;
            case 'I':
                cypherText += "K";
                break;
            default:
                cypherText += c; 
                break;

        }
    }
    return cypherText;
}

//tekst do zaszyfrowania
string clearText = "";
Console.WriteLine("Prosze podaj tekst do zaszyfrowania: ");
clearText= Console.ReadLine() ?? "";

//zamien na wielkie litery
clearText= clearText.ToUpper();

//zaszyfruj uzywajac funkcji
string cypherText = gaderypuluki(clearText);

Console.WriteLine("Zaszyfrowany tekst (metoda1):  " + cypherText);
Console.WriteLine("Zaszyfrowany tekst (metoda2):  " + cypherText);

