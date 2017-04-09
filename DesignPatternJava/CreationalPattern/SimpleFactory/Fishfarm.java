package chap2;

/**
 * Created by lionel on 2017/4/9.
 */
public class Fishfarm
{
    public static Freshwaterfish producefish(String type)
    {
        if("鲶鱼".equals(type))
        {
            return new Catfish();
        }
        else
        {
            return null;
        }
    }
}
