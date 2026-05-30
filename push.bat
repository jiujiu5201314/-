@echo off
cd /d E:\VS\WindowsFormsApp1
echo === ???? ===
git status
echo.
echo === ????... ===
git add -A
git commit -m "?? %date% %time%"
git push
echo.
echo === ?? ===
pause
