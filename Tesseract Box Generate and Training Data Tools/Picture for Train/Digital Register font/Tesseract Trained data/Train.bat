cd /d "C:\Users\mcsnavin\Pictures\Digital Register font\Tesseract Trained data"
"C:\Program Files (x86)\Tesseract-OCR\tesseract" seg.tif seg --psm 7 box.train

echo Compute the Character Set..
"C:\Program Files (x86)\Tesseract-OCR\unicharset_extractor.exe" seg.box
"C:\Program Files (x86)\Tesseract-OCR\set_unicharset_properties" -U unicharset -O unicharset --script_dir=%~dp0
"C:\Program Files (x86)\Tesseract-OCR\shapeclustering" -F "C:\Program Files (x86)\Tesseract-OCR\font_properties" -U unicharset -O seg.unicharset seg.tr
"C:\Program Files (x86)\Tesseract-OCR\mftraining" -F "C:\Program Files (x86)\Tesseract-OCR\font_properties" -U unicharset -O seg.unicharset seg.tr

echo Clustering.. 
"C:\Program Files (x86)\Tesseract-OCR\cntraining.exe" seg.tr

echo Delete Existing Files..
del seg.normproto
del seg.inttemp
del seg.pffmtable
del seg.shapetable

echo Rename Files..
rename normproto seg.normproto
rename inttemp seg.inttemp
rename pffmtable seg.pffmtable
rename shapetable seg.shapetable

echo Create Tessdata..
"C:\Program Files (x86)\Tesseract-OCR\combine_tessdata.exe" seg.

echo & pause