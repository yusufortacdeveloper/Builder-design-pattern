public class EnemyBuilder
{
    private Enemy enemy;

    public EnemyBuilder()
    {
        enemy = new Enemy();
    }

    public EnemyBuilder SetName(string name)
    {
        enemy.Name = name;
        return this;
    }

    public EnemyBuilder SetHealth(int health)
    {
        enemy.Health = health;
        return this;
    }

    public EnemyBuilder SetAttackDamage(int attackDamage)
    {
        enemy.AttackDamage = attackDamage;
        return this;
    }

    public Enemy Build()
    {
        return enemy;
    }
}

// yusufortacdeveloper
