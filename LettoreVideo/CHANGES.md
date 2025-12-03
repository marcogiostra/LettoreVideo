Changelog
=========

-------------------
 On Development
-------------------


-------------------
VERSIONI e FIX
-------------------
v1.3.0 - 03/12/2025

- cambiata icona del programma
- aggiunto il cambo Visto (bool) per segnbare che lo abbiamo visto
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

