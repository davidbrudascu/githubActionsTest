find ./InstallFiles/ -name *.sql ! -path '*-.old*' | awk -F "/" '{split($NF,a,"."); print sprintf("%s/%s/%s/%s",$1,$2,$3,a[1])}' | uniq -D
