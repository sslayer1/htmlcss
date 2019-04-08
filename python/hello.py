from POL import Image
from sys import  argv

if len (argv) != 4:
    exit ("Usage:Python resize.py n infilr outfilr")

n = int(argv[1])    
infile=argv[2]
outfile = argv[3]

inimage = Image.open(infile)
width,height = inimage.size
outimage = inimage.resize((width * n, heigh * n))

outinage.save(outfile)
 