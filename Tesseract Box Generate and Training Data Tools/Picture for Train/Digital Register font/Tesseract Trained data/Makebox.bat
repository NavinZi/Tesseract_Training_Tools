cd /d C:\Program Files (x86)\Tesseract-OCR

echo Make Box File

tesseract "C:\Users\mcsnavin\Pictures\Digital Register font\0-9(2).tif" "C:\Users\mcsnavin\Pictures\Digital Register font\Tesseract Trained data\seg2" --psm 7 makebox
