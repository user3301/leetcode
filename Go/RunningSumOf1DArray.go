package gosoln

func RunningSum(nums []int) []int {
	dp := make([]int, len(nums)+1)
	dp[0] = 0
	for i := 1; i < len(dp); i++ {
		dp[i] = dp[i-1] + nums[i-1]
	}
	return dp[1:]
}
