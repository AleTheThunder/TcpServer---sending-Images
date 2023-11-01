Bildübertragungsprogramm
Dieses Programm ermöglicht die Übertragung von Bildern zwischen einem Server und einem Client über eine TCP-Verbindung.

Anforderungen
.NET Core 5.0 oder höher
Verwendung
Server
Kompiliere und starte das Serverprogramm.
Der Server wartet auf eingehende Verbindungen.
Client
Kompiliere und starte das Clientprogramm.
Der Client verbindet sich mit dem Server.
Der Client wählt das Bild aus, das er senden möchte.
Das Bild wird zum Server übertragen.
Anzeige des empfangenen Bildes
Das empfangene Bild wird als "received_image.jpg" im gleichen Verzeichnis wie das Client-Programm gespeichert.
Fehlerbehebung
Wenn Probleme beim Starten oder Ausführen des Programms auftreten, überprüfe die Netzwerkeinstellungen und stelle sicher, dass die Verbindung zum Server hergestellt werden kann.
