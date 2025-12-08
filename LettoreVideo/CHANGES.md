Changelog
=========

-------------------
 On Development
-------------------


-------------------
VERSIONI e FIX
-------------------
v.14.3 + v.14.4 - 08/12/2025
-----------------------------------------------
- con l'opeazione di savataggio di nuovi filmati in archivio, pulisce la play list.
- la maschera di inputbox è stata sistemata.
- risolto il problema di selzionrare e manipolare lo satto di pregressione del video che con l'ultima modifica della comparsa del overly botton,
          non era può utilizzabile.
- i tre pulsanti per aumentare di 5, 10 e 30 secondi sono stati corretti
- corretto la gestione del path iniziale nel browser dialog
- aggiunto un promi step per velocizzare.
          NB: è possibile un secondo, ma aspetto per vedere se sia effettivamente necessario ,o basta il primo
- creato nuovp pulsante per mostrare nuovamente il titolo del video (posto nell'overlat bottom)
- preata procedura per scegliere il vidoe corrente dalla playlist, e se c'è un altro video in esecuzione, il nuovo viene subito eseguito
- modifica su VIDEO_PLAY per eliminare una linea diu codice che impediva la selezione di una nuova play-list all'inizio dell'app con il diretto esecuzione
- sostituito il controllo per la velocità del video. Quello nuovo è tropppo elementare e forse dovrò cambiarlo in seguito


v1.4.2 - 07/12/2025
-----------------------------------------------
- cambiato il browser folder dialog con uno che faccia vedere il contenutoi della cartella. Elementare ma è un buon inizio

v1.4.1 - 06/12/2025
-----------------------------------------------
- CORRETTO RESIZE DEL FORM DI OVERLAY toP CHE SBAGLAIVA IL RIODINAMENTO ,ANASCINDENDI IL save SOTTO UN ALTRO PULSANTE

v1.4.0 . 06/12/2025
-----------------------------------------------
- nella maschera di gestione dell'archivio, aggiunto la possibilità di modificare il titolo
- nella maschera di gestione dell'archivio, sistemato i colori del context menu
- nella maschera di gestione dell'archivio, aggiunto filtraggio dei files: TUTTTI - VISTI SI - VISTI NO
- nella maschera di gestione dell'archivio, corretto la modifica e il salvataggio dei valori per tennere conto del filtraggio
- nella maschera di gestione dell'archivio, è sta cambiata la voce del menu relativo al cambio0 del flag VISTO/NON VISTO
- correto baco sulla chiusra della InputBox senza cambiare nulla
- aggiunto la visualizzazione del titolo dopo l'avvio del prano dopo 1 sec, rimane visualizzaot per 3 sec
- cambiato l'opacity del form dei pulsanti (Overlay2) pe renderlo più trasparente
- ho creato un secondo overlayform che scende dall'alto dove ho messo i bottoni di gestione archivio e il pulsante di chiusura dell'applicativo
- riscirtta il timer per la comparsa dei due overlay per risolvere i problemi con la modalità schermo video FULL CON TASKBAR
- dentro il gestore file json creato funzione i caricamento dei video del DB tolta dal maschera principale
- elimato la funzionalità gestione archivio  vecchia, perchè è diventyata obsoleta con la nuova maschera di gestione dell'archivio (seconda dove può cambiare i dati)
- corretto piccolo baco della gestione liste da eseguire in modo che adesso ritorni il nomero totale giusto di elementi rimasti in lista
- nella maschera delal scelta dei file da archivio da aggiungere nella lista ho aggiunto optra la polsante download anche quello di download+play che fa suonare il primo

v1.3.0 - 03/12/2025
-----------------------------------------------
- cambiata icona del programma
- aggiunto il cambo Visto (bool) per segnare che lo abbiamo visto
- al salvataggio pdove prima creava  db.bak ora dopo il salvataggi odi db.jsom, cancella il .bak
- nella gestione files, l'eliminazione è diventata esclusione dall'archivio, e chiede se deve anche eliminare il file fisico
- aggiunto il flag Visto al TreeView della maschera di gestione dei files e di scelta
- corretto la funzione di scrittura del db in formato json per evitare errori nella creazione del file di backup se non esiste quello di db

v1.2.3 - xx/xx/2025
-----------------------------------------------
- nel file json non viene salvato il path effettivo di un video, ma quello relativo se sullo steffo drive dell'applicativo
- nelle informazioni del json la proprietà Cartella è stata sostituita da due proprietà: Categoria e Specifica per migliorare la classificazione
- nel form di scelta ho sotrituito la checklistboxo con un listview in modalità checkbox per migliorare l'usabilità e aggiunto categoria e specifica
- aggiunto la  macchina fotografica di un frame che salva in mypictures/immagini
- cambiate alcune icone

v1.2.0 - 21/10/2025
-----------------------------------------------
- ridefinita overlayform con diverse icone e gestione

v1.1.0 - 21/10/2025
-----------------------------------------------
- cambiata finestra e barra degli oggetti

v1.0.0 - 20/10/2025
-----------------------------------------------
- prima versione

