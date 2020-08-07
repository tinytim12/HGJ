/*

The MIT License (MIT)

Copyright (c) 2015-2017 Secret Lab Pty. Ltd. and Yarn Spinner contributors.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/

using UnityEngine;
using UnityEngine.SceneManagement;


namespace Yarn.Unity.Example {
    /// attached to the non-player characters, and stores the name of the Yarn
    /// node that should be run when you talk to them.

    public class NPC : MonoBehaviour {

        public string characterName = "";

        public string talkToNode = "";

        private DialogueRunner dialogueRunner;

        private Collider2D collider;

        [Header("Optional")]
        public YarnProgram scriptToLoad1;
        public YarnProgram scriptToLoad2;
        public YarnProgram scriptToLoad3;


        void Start() {
            dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
            // do whatever you like
            int day = GameObject.Find("GameController").GetComponent<GameController>().getDay();
            if (day == 1) {
                dialogueRunner.Add(scriptToLoad1);
                talkToNode = "ThiruDay1.1";
            } else if (day == 2) {
                dialogueRunner.Add(scriptToLoad2);
                talkToNode = "Start2";
            } else if (day == 3) {
                dialogueRunner.Add(scriptToLoad3);
                talkToNode = "Start3";
            }

            dialogueRunner.StartDialogue(talkToNode);
        }

    }

}
