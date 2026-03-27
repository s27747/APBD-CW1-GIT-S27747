To repozytorium zawiera zadania z konfiguracji Git, pracy na gałęziach, merge, rebase oraz rozwiązywania konfliktów.

Zadanie nr 6: W tym zadaniu uczę się używać rebase.

 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

Git wykona fast-forward wtedy, gdy gałąź docelowa nie ma nowych commitów od momentu utworzenia drugiej gałęzi. W takiej sytuacji Git tylko przesuwa wskaźnik gałęzi do przodu.

Merge commit powstaje wtedy, gdy obie gałęzie mają własne, niezależne commity i ich historia się rozeszła. Wtedy Git musi utworzyć dodatkowy commit scalający.

 2. Czym w praktyce różni się merge od rebase?

Merge scala historię dwóch gałęzi i zachowuje informację o rozgałęzieniu. Rebase przenosi commity jednej gałęzi na szczyt drugiej, przez co historia jest bardziej liniowa i czytelna.

W praktyce merge pokazuje rzeczywisty przebieg pracy na branchach, a rebase porządkuje historię.

 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Konflikt został wywołany przez zmianę tego samego fragmentu kodu w pliku Program.cs na gałęzi main i na gałęzi feature-conflict.

Rozwiązanie polegało na ręcznym przejrzeniu obu wersji kodu, usunięciu markerów konfliktu i zapisaniu jednej, końcowej wersji, która zachowuje poprawne działanie programu. Następnie plik został dodany do repozytorium i wykonano commit kończący scalanie.