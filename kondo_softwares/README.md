# Kondo Softwares

This directory contains 3rd party softwares and drivers for the Kondo robot KHR-3HV. They were downloaded from the official website [kondo-robot.com](http://kondo-robot.com/for_english).

We tested most of these softwares on Windows 10 and Windows 7. Because they did not work well on Windows 10, we mostly used them on Windows 7.

Details of each folder:

* KO_Driver2015: this directory contains the drivers for the ICS/Serial/Dual USB Adapters for Windows. Once you have connected the robot to the USB port using the USB adapter, open the 'Device Manager', right-click on the 'USB Adapter' that appeared, and click on 'update drivers'. Then, select this folder from which to install the drivers. For more information, follow the instructions in the corresponding manual (which is inside this folder).

* ICS3.5Manager1003: this folder contains the software that allows you to change the configuration of a servo motor. You will need to connect directly the servo to the computer using the USB Adapter. Please check the 'ICS3.5 Serial Manager' manual inside the directory to see how to perform that. The (KRS-2552) servos (that comes with the KHR-3HV robot) use the ICS 3.5 protocol to communicate. More information about this last one can be found in the other manual 'ICS3.5 Software Manual'.

* RCB4RefSetV220R20140507: this directory contains the software to generate the commands to send to the RCB4 controller board. It also contains documentation (in Japanese) about the format of these commands and other stuffs. This software and documentations were extremely useful when writing/updating the code of the libkondo4 library.

* HTH4V220Beta: This folder contains the software 'HeartToHeart4' that allows you to send motions to the RCB4 controller board, and play it on the robot.


## How to read Japanese?

Some manuals/softwares are in Japanese, how to read them?
Well, you can use google translate to mostly understand what they mean. Otherwise, you can learn to read [katakana](https://en.wikipedia.org/wiki/Katakana) to understand a part of it. "In modern Japanese, katakana is most often used for transcription of words from foreign languages" (from Wikipedia). Most often, they are retranscription of English words but with a Japanese pronunciation. That is, by reading them aloud you could try to figure out the english word that is the most similar to the pronounced word.
It is usually very easy for English speaking people to pronounce japanese sounds/words.
While reading, just keep in mind that in Japanese:
- there are no words that ends with a consonant (except for 'n'). For instance, 'command' is pronounced ko-ma-n-do (コマンド), 'bus' is pronounced 'ba-su' (バス). Sometimes the last consonant would be disregarded such as 'restaurant' -> re-su-to-ra-n (レストラン), or the last vowel sound would be extended such as 'motor' -> mo-o-ta-a (モーター).
- each consonant must be separated using a vowel. For instance, words like 'play' becomes pu-re-i (プレイ), 'restaurant' becomes re-su-to-ra-n (レストラン).

Here are few other examples taken from the various manuals inside this folder:
* プロガミング = pu-ro-ga-mi-n-gu = programming
* サーボ モーター = sa-a-bo mo-o-ta-a = servo motor
* シリアル USB アダプター = shi-ri-a-ru USB A-da-pu-ta-a = Serial USB Adapter 
* コマンド リファレンス マニュアル = Ko-ma-n-do ri-fa-re-n-su ma-nyu-a-ru = Command Reference manual
