class TwoSumChallenge(object):
    """
    Finds the indexes of the first number pair (two numbers) in a given array that when
    added (the number not their indexes) sums up to exactly the given target.

    Parameters
    -----------
    nums: List of integers
        List of numbers to be traversed.
    target: int
        The target value to be checked.

    Description
    ------------
    The approach is to use the algebra concept that if a + b = c; then a = c - b
    or b = c -a, where c is the target; a and b are the array values. A dictionary
    is created to keep track of values (as the key) and their indexes(as the value).
    At the end, it returns the indexes of the values that add up to the target.

    Example
    --------
    Given a list of integers: [8, 2, 9, 4, 5], and a target value: 13, The first pair
    from the list that sums up to 13 is 9 and 4, i.e, 9 + 4 = 13. Then, the
    function returns their indexes as [2, 3].

    Returns
    ---------
    List: int
        Indexes of the two nums (that add up to the target)
    """
    def twoSum(nums: list[int], target: int) -> list[int]:
        #A dictionary to hold the value and their indexes
        hashTable: dict = {}

        # Loops through the given list: nums
        for i, num in enumerate(nums):
            # Checks say; a = c - b starting from first value in the list
            # where a = x; c = target, and b = num
            x:int = target - num

            # Checks if dictionary has a key <a> in it. If yes, it returns
            # the value of the <a> key and the index of b - the present index
            if x in hashTable:
                return [hashTable[x], i]
            
            # If the key <a> is not found in the dictionary, it populates it with <b> as the
            # key and the index of <b> as the value
            hashTable[num] = i

        # Returns [-1, -1] if not found
        return [-1, -1]

# Calls the twoSum method on and prints the value
print(TwoSumChallenge.twoSum([8, 2, 9, 4, 5], 13))