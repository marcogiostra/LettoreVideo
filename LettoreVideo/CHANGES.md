Changelog
=========

-------------------
 On Development
-------------------


-------------------
VERSIONI e FIX
-------------------

v1.4.1 - 06/12/2025
-----------------------------------------------
- CORRETTO RESIZE DEL FORM DI OVERLAY toP CHE SBAGLAIVA IL RIODINAMENTO ,ANASCINDENDI IL save SOTTO UN ALTRO PULSANTE
-
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

