using Lab2.Queue;
using NUnit.Framework;

namespace Lab2Test.Queue
{
    [TestFixture]
    public class MQueueTest
    {
        [Test]
        [TestCase(new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3 })]
        public void TestEnqueueDequeue1(int[] items)
        {
            MQueue queue = new MQueue();
            for (int i = 0; i < items.Length; i++)
            {
                queue.Enqueue(items[i]);
            }
            for (int i = 0; i < items.Length; i++)
            {
                Assert.AreEqual(items[i], queue.Dequeue());
            }
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 })]
        public void TestEnqueueDequeue2(int[] items)
        {
            MQueue queue = new MQueue();
            queue.Enqueue(items);
            for (int i = 0; i < items.Length; i++)
            {
                Assert.AreEqual(items[i], queue.Dequeue());
            }
        }

        [Test]
        public void TestMinMax1()
        {
            MQueue queue = new MQueue();

            queue.Enqueue(1, 2, 3);
            Assert.AreEqual(1, queue.Min());
            Assert.AreEqual(3, queue.Max());

            queue.Dequeue();
            Assert.AreEqual(2, queue.Min());
            Assert.AreEqual(3, queue.Max());

            queue.Dequeue();
            Assert.AreEqual(3, queue.Min());
            Assert.AreEqual(3, queue.Max());
        }

        [Test]
        public void TestMinMax2()
        {
            MQueue queue = new MQueue();

            queue.Enqueue(7, 0, 1);
            Assert.AreEqual(0, queue.Min());
            Assert.AreEqual(7, queue.Max());

            queue.Dequeue();
            Assert.AreEqual(0, queue.Min());
            Assert.AreEqual(1, queue.Max());

            queue.Dequeue();
            Assert.AreEqual(1, queue.Min());
            Assert.AreEqual(1, queue.Max());
        }
    }
}
