## Introduction

ObfuscationTest is a simple project which produce a dll and ObfuscationTestApp uses the dll.

I want to test whewher It can work in this simplest situation under Release Configuration. 



## Build Instuction

1. Build the ObfuscationTest in Release x86 mode.
2. Obfuscate the dll produced above in ObfuscationTest\bin\x86\Release
3. Replace the origin dll by the obfuscated dll in ObfuscationTest\bin\x86\Release\ObfuscationTest_Secure
4. Run the ObfuscationTestApp in Release x86 mode



I found there is still errors about "Invild IL" in the runtime. 