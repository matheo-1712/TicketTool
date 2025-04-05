#!/bin/bash

dotnet publish -c Release -o out

# Redémarrer le service pour appliquer les modifications
sudo systemctl restart ticketool

