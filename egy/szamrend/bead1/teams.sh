#!/bin/sh

case $1 in
    "-lista")
        cat teams.dat | cut -d ',' -f 1,3 | grep "$2" | cut -d ',' -f 1
        ;; 
    "-hallgato")
        code=`grep "$2" hallgato.dat | cut -d ',' -f 2- | tr ',' '\n'`
        for i in $code
        do
            oktatok=`grep "$i" teams.dat | cut -d ',' -f 3 | sort -u | cut -d " " -f 2-`
            echo "$oktatok">>asd
        done
        cat asd | uniq
        rm asd
        ;;
    "-sok")
        cat teams.dat | cut -d ',' -f 3 | sort | uniq -c | sort -r | tr -s ' ' | cut -d ' ' -f 3,4 | head -n1
        ;;
esac
