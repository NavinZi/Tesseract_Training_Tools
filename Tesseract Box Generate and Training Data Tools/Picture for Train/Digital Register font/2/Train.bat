cd /d "C:\Users\mcsnavin\Pictures\Digital Register font\2"
"C:\Program Files (x86)\Tesseract-OCR\tesseract" seg2.tif seg2 --psm 7 box.train

echo Compute the Character Set..
"C:\Program Files (x86)\Tesseract-OCR\unicharset_extractor.exe" seg2.box
"C:\Program Files (x86)\Tesseract-OCR\set_unicharset_properties" -U unicharset -O unicharset --script_dir=%~dp0
"C:\Program Files (x86)\Tesseract-OCR\shapeclustering" -F "C:\Program Files (x86)\Tesseract-OCR\font_properties" -U unicharset -O seg2.unicharset seg2.tr
"C:\Program Files (x86)\Tesseract-OCR\mftraining" -F "C:\Program Files (x86)\Tesseract-OCR\font_properties" -U unicharset -O seg2.unicharset seg2.tr

echo Clustering.. 
"C:\Program Files (x86)\Tesseract-OCR\cntraining.exe" seg2.tr

echo Delete Existing Files..
del seg2.normproto
del seg2.inttemp
del seg2.pffmtable
del seg2.shapetable

echo Rename Files..
rename normproto seg2.normproto
rename inttemp seg2.inttemp
rename pffmtable seg2.pffmtable
rename shapetable seg2.shapetable

echo Create Tessdata..
"C:\Program Files (x86)\Tesseract-OCR\combine_tessdata.exe" seg2.
