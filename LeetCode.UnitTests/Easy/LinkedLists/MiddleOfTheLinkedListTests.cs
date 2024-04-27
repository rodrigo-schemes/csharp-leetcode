using FluentAssertions;
using LeetCode.Easy.LinkedLists;
using LeetCode.Shared;

namespace LeetCode.UnitTests.Easy.LinkedLists;

public class MiddleOfTheLinkedListTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void MiddleOfTheLinkedList_UnitTest(ListNode nodes, int middle)
    {
        var result = MiddleOfTheLinkedList.Run(nodes);
        result.Val.Should().Be(middle);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { new ListNode(1, 
            new ListNode(2, 
                new ListNode(3, 
                    new ListNode(4, 
                        new ListNode(5,
                            new ListNode(6)
                            )
                        )
                    )
                )
            ), 4
        };
        
        yield return new object[] { new ListNode(1, 
                new ListNode(2, 
                    new ListNode(3, 
                        new ListNode(4, 
                            new ListNode(5)
                        )
                    )
                )
            ), 3
        };
    }
}