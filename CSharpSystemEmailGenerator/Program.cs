// i'm losing it
// this is the fourth time ive redone this repo because i am incompetent and the last 3 were FUBAR.
// at least all the bash scripts and random directories are still existing on the server
// that is unless it decides to lobotomize itself for the fourth time in the past 2 months
// ive kinda forgotten what i was even doing with this project
// something something automated email report generator using a local llm on an orange pi 5
// gathers a buncha data from random things and a long-running daemon and then throws all that at the llm and pretty much says "heres a bunch of data, write a report, good luck"
// no npu or gpu inference because the stupid kernel armbian shipped with has lousy drivSer support
// not even going to attempt messing with the kernel to try and get drivers, i do not want to set everything up again
// cpu inference it is, measly 7 tokens a second generation and 4 prompt eval
// i cant even remember half the data points i wanted to gather and the ragtag setup i did for this will probably exceed the context window with log errors alone
// im sure i had a good reason for doing this but i cant remember what it was