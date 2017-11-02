/**
 * ExamplePlayMotion
 * An example of how to use the Java SWIG bindings
 * 
 * Copyright 2010 - Christopher Vo (cvo1@cs.gmu.edu)
 * George Mason University - Autonomous Robotics Laboratory
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

public class ExamplePlayMotion {
	static {
		System.loadLibrary("kondo_java");
	}

	public static void error(KondoInstance ki) {
		System.out.println(ki.getError());
		System.exit(-1);
	}

	public static void main(String args[]) {
		System.out.println("Creating KondoInstance...");
		KondoInstance ki = new KondoInstance();
		int ret = kondo.kondo_init(ki);
		if(ret < 0) error(ki);

		System.out.println("Playing motion...");
		int motion_num = 0;
		int max_wait = 50 * 1000000;
		ret = kondo.kondo_play_motion(ki, motion_num, max_wait);
		if(ret < 0) error(ki);
 
		System.out.println("Closing KondoInstance...");
		ret = kondo.kondo_close(ki); 
		if(ret < 0) error(ki);
	}
}
