[HttpPost]
public async Task<IActionResult> CreateUser([FromBody] UserCreateDto dto)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    // Логіка створення користувача...
    return Ok("Користувач успішно створений.");
}
