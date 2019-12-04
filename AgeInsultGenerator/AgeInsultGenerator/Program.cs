using System;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            string results =null;
            Console.WriteLine("Enter an age so I can make fun of you. ");
            enterAge = Convert.ToInt32(Console.ReadLine());

            
            if (enterAge <= 12)
            {
                results = "you are a 8th grade punk.";
            }
            else if (enterAge > 13 && enterAge <= 17)
            {
                results = "The mallenial generation was a mistake.";
            }
            else if (enterAge > 18 && enterAge <= 25)
            {
                results = "get out of your mother basement bruv.";
            }
            else if (enterAge > 26 && enterAge <= 35)
            {
                results = "Wow look at you Married two kids and a morgage, I bet you also have a 401k and health insurance.";
            }
            else if (enterAge > 36 && enterAge <= 45)
            {
                results = "bet is sucks not haveing working knees and an acking back all day.";
            }
            else if (enterAge > 46 && enterAge <= 55)
            {
                results = "You know I find it ironic that your generation always talks about how " +
                    "hooked the mallenial generation are to their tech seeing how you now have to whear life alerts and " +
                    "and rely on modern medicins in order to live as long as you have yah boomer.";
            }
            else if (enterAge >= 65)
            {
                results = "Your old and I respect that";
            }
            if (enterAge <= 0)
            {
                results = "According to all known laws of aviation, " +
                    "there is no way a bee should be able to fly. " +
                    "Its wings are too small to get its fat little " +
                    "body off the ground. The bee, of course, flies anyway" +
                    " because bees don't care what humans think is impossible. " +
                    "Yellow, black. Yellow, black. Yellow, black. Yellow, black. Ooh, " +
                    "black and yellow! Let's shake it up a little. Barry! Breakfast is ready! " +
                    "Ooming! Hang on a second. Hello? - Barry? - Adam? - Oan you believe this is" +
                    " happening? - I can't. I'll pick you up. Looking sharp. Use the stairs." +
                    " Your father paid good money for those. Sorry. I'm excited. Here's the graduate." +
                    " We're very proud of you, son. A perfect report card, all B's. Very proud. Ma! I got a thing going here. - You got lint on your fuzz. - Ow! That's me! - Wave to us! We'll be in row 118,000. - Bye! Barry, I told you, stop flying in the house! - Hey, Adam. - Hey, Barry. - Is that fuzz gel? - A little. Special day, graduation. Never thought I'd make it. Three days grade school, three days high school. Those were awkward. Three days college. I'm glad I took a day and hitchhiked around the hive. You did come back different. - Hi, Barry. - Artie, growing a mustache? Looks good. - Hear about Frankie? - Yeah. - You going to the funeral? - No, I'm not going. Everybody knows, sting someone, you die. Don't waste it on a squirrel. Such a hothead. I guess he could have just gotten out of the way. I love this incorporating an amusement park into our day. That's why we don't need vacations. Boy, quite a bit of pomp... under the circumstances. - Well, Adam, today we are men. - We are! - Bee-men. - Amen! Hallelujah! Students, faculty, distinguished bees, please welcome Dean Buzzwell. Welcome, New Hive Oity graduating class of... ...9:15. That concludes our ceremonies. And begins your career at Honex Industries! Will we pick ourjob today? I heard it's just orientation. Heads up! Here we go. Keep your hands and antennas inside the tram at all times. - Wonder what it'll be like? - A little scary. Welcome to Honex, a division of Honesco and a part of the Hexagon Group. This is it! Wow. Wow. We know that you, as a bee, have worked your whole life to get to the point where you can work for your whole life. Honey begins when our valiant Pollen Jocks bring the nectar to the hive. Our top-secret formula is automatically color-corrected, scent-adjusted and bubble-contoured into this soothing sweet syrup with its distinctive golden glow you know as... Honey! - That girl was hot. - She's my cousin! - She is? - Yes, we're all cousins. - Right. You're right. - At Honex, we constantly strive to improve every aspect of bee existence. These bees are stress-testing a new helmet technology. ";


            }
            Console.WriteLine(results);
        }
    }
}
